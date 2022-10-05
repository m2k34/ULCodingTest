# ULCodingTest

Approach:

To solve this problem. Using bodmass, I thought to loop through a list of operands and operators to find an operator 
and then use this operator to instantiate an object which is an expression that contains the first number and the second, also the operator. 

My goal in doing this is to first evaluate sub expressions within the whole expression if there are any.
After an expression has been evaluated the program will replace the expression in the list with the result of the evaluation.
This will then check to see if there are still any operators within the list.
If there are any, I use recursion to do the same logic on the updated expression until there are none.

By doing so I can tell the program to start by evaluating any division expressions and then multiplication expressions.
After doing so it'll will evaluate any addition or subtraction if there are any. Until the last value left is a single item which is the sum.

To make this code more maintainable I seperated methods into their own relative classes. I created a seperate parser class as well as a seperate calculator class. Also by creating an object named Expression with its own properties I ensured that the code was easier to read.
