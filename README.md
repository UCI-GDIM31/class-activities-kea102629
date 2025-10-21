# in-class-activities
## Devlogs
### W1
Hello world!
### W2
Create future Devlog sub-headers with the three # symbols, then write your Devlogs below them.
1. Why are the r, g, and b variables floats instead of ints, bools, or strings?
the r g b values are decimal values from 0-1.0 so they should be floats as ints are only whole numbers and strings are for text
2. Why is the _bounce variable an int instead of a float, bool, or string?
_bounce is an int beacuse the number of bounces is a whole number. You cant have half a bounce so it cant be a float and its not text so it cant be a string. 
3. The error you got after Step X of Part 2 told you something useful about why that line of code was broken- what was it?
The error told me that I was missing a semicolon at the end of the line.
### W3
Tables 17
You’re building a horror game, and you’re writing a method named SetLightDimness that makes the room’s lights brighter or darker based on the player’s current sanity level. The player’s sanity level is a number that goes from 0% - 100%. The method changes the light itself, so it doesn’t need any output.

The input would be a float and there would be no output.

With your table mates, come up with a metaphor to explain the relationship between classes and Components with a metaphor. Also describe how methods and member variables factor into that metaphor.  Remember that classes are templates that can become Components; member variables are traits of each class; and methods are things the class can do.

If we imagine a game as a computer the components are features like the keyboard and mouse, the classes are things every keyboard and mouse does/the general features of a keyboard and mouse, the methods are how the keyboards and mouses work for exmaple what happens when you click a key or right click and finally variables are the actual information put into methods or in classes. For example if we imagine pressing the j key on your keyboard the method would be to put the key pressed into this text file and the variable to put into the method would be j.

Why do you think the balls get extremely bright, especially in the Scene, if they bounce too many times?
The colour keeps multplying exponetially.
### W4
Table 17:
Do your best to describe the following lines of code:

    line 17: private bool _isGrounded = true;
    This sets a member variable of type boolean to the value true 

    line 28: if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
    This line calls the method GetKeyDown() with the parameter KeyCode.Space to see if the space key was clicked and it checks if the isGrounded member variable is true.

    line 32:_isGrounded = false;
    This line changes the _isGrounded member variable to false
Table #17

What solution did you come up with for the collider activity, and why? Specifically- which objects did you add Rigidbodies to, and which object(s) did you check Is Trigger on?

We added Rigidbodies to the cat and the soccer ball and cliked Is Trigger for the goal. Becausee we need the cat and the ball to physicall collide with other objects while for the goal we need to check if the ball entered it. 

IF your game did not work perfectly the first time you tested it, talk about what you had to fix.

I also clicked Istrigger for the ball and it fell through the floor. To fix it i unchecked Is Trigger. The size of my collider for the cat was also too big so it started floating. I changed the size and center of the collider.



## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 