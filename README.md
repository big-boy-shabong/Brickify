# Brickify
Converts normal pictures to lego pictures

This is brickify 1.0.0
First release build many more features planned if I can be bothered to make them.

Common colours are colours that regularly have over 1000 bricks on bricklink available.
most colours are still avaiable and don't cost more than 2p so are still viable but will
potentially make an awkward order.
Greyscale uses new lego grey colours (light grey and dark grey is discontinued)

Note that lego baseplates come in 48x48 and 32x32 configureations.

Dithering uses floyd steinbeck method, just makes them look better.
Aspect ratio does the thing you would expect.

Saturation is between -255 and 255 for each colour. it offsets the image deeper or lesser
into that hue. 

Saving a file also adds a text file to the directory, this contains the bricks you need to 
create that image and a link where to buy them.

Improvements to make:
-add multi brick type generation
-heightmap additions
-different dithering options
-different default methods of hue connection as euler distance rgb counter intuitively doesnt
produce the most visually similar colours.


