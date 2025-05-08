import xml.etree.ElementTree as ET
import colorsys
import re


def hex_to_rgb(hex_color: str) -> tuple[int, int, int]:
    hex_color = hex_color.lstrip("#")
    if len(hex_color) == 3:
        hex_color = "".join(c * 2 for c in hex_color)
    return tuple(int(hex_color[i : i + 2], 16) for i in (0, 2, 4))


def rgb_to_hex(rgb: tuple[int, int, int]) -> str:
    return "#{:02x}{:02x}{:02x}".format(*rgb)


def is_near_black_or_white(rgb: tuple[int, int, int], threshold: int = 30) -> bool:
    return all(c <= threshold for c in rgb) or all(c >= 255 - threshold for c in rgb)


def adjust_saturation(
    rgb: tuple[int, int, int], factor: float = 1.3
) -> tuple[int, int, int]:
    r, g, b = [c / 255.0 for c in rgb]
    h, l, s = colorsys.rgb_to_hls(r, g, b)
    s = min(s * factor, 1.0)
    r, g, b = colorsys.hls_to_rgb(h, l, s)
    return tuple(int(c * 255) for c in (r, g, b))


def process_svg(input_path: str, output_path: str) -> None:
    ET.register_namespace("", "http://www.w3.org/2000/svg")
    tree = ET.parse(input_path)
    root = tree.getroot()

    for elem in root.iter():
        fill = elem.attrib.get("fill")
        if not fill:
            continue
        fill = fill.strip()
        if fill.lower() in ["none", "currentcolor"]:
            continue
        if fill.startswith("#"):
            try:
                rgb = hex_to_rgb(fill)
            except ValueError:
                continue
        elif fill.lower().startswith("rgb"):
            nums = re.findall(r"\d+", fill)
            if len(nums) != 3:
                continue
            rgb = tuple(map(int, nums))
        else:
            continue

        if is_near_black_or_white(rgb):
            elem.set("fill", "currentColor")
        else:
            adjusted_rgb = adjust_saturation(rgb)
            elem.set("fill", rgb_to_hex(adjusted_rgb))

    tree.write(output_path, encoding="utf-8", xml_declaration=True)
