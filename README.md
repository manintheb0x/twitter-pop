# twitter-pop

An easy to use tool that will:  

1.) Parse text input into a string array, each element being <= 140 characters, taking whole words into consideration (ie. will not split a whole word).

    Example: 
    
      If the character limit was 10 characters
      
      input >> "This is S1 this is S2 and S3"
      
      would be parsed into memory as a string array with 3 elements: 
        strArray[0] = "This is S1"
        strArray[1] = "this is S2"
        strArray[2] = "and S3"

2.) Reverse the array order.

    Example: 
    
      strArray[0] = "This is S1"
      strArray[1] = "this is S2"
      strArray[2] = "and S3
      
      would become: 
        strArray[0] = "and S3"
        strArray[1] = "this is S2"
        strArray[2] = "This is S1"
    
3.) Post each array element in the new order to Twitter. 

    Example: 
      
      strArray[0] = "and S3"
      strArray[1] = "this is S2"
      strArray[2] = "This is S1"
      
      would output to Twitter as: 
        Tweet 1: and S3
        Tweet 2: this is S2
        Tweet 3: This is S1
        
