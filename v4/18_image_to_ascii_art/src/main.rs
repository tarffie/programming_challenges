use image::{GenericImageView}; 
// IMAGE 
// pixels(x, y) => let pixel = img.get_pixel(x, y);
// it returns me an array of (0, 0), I guess that's a bidimensional array?? 
/*
[[0], [1], [2]]
*/

fn get_str_ascii(intent: u8) -> &'static str { 
    let index = intent/32;
    let ascii = [" ", ".", ",", "-", "~", "+", "=", "@"];
    return ascii[index as usize];
}

fn get_image(dir: &str, scale: u32) { 
    let img = image::open(dir).unwrap(); 
    let (width, height) = img.dimensions();
    for y in 0..width { 
	for x in 0..height { 
	    if y % (scale * 2) == 0 && x % scale == 0 { 
		let pixel = img.get_pixel(x, y);
		let mut intent = pixel[0] / 3 + pixel[1] / 3 + pixel[2] / 3;
		if pixel[3] == 0 {
		    intent = 0;
		}
		print!("{}", get_str_ascii(intent));
	    }
	}
	if y % (scale*2) == 0 {
	    println!("");
	}
    }
}

fn main() {
    get_image("images/zerotwo.jpg", 12);
}
