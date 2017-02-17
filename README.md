# Word Counter

#### _Count the instances of one word in a sentence or paragraph, February 17, 2017_

#### By _**Katherine Matthews**_

## Description

_The webpage returns the number of times a specific word shows up in a text. Text size can be a sentence, paragraph, etc. Submit button brings user to page with results displayed https://katherinemat.github.io/word-counter/_

## Specifications
1. Return the word the user types in because this is the simplest task a user would want the program to perform; input: steak; output: steak
2. Check that two words that the user enters are the same. Comparing one word to itself is the easiest instance to check for a match; input: tennis, tennis; output: true
3. Compare two sentences to see if they are equal. This is similar to the previous spec, just making sure that spaces and other special characters are taken into consideration; input: I can't!, I can't!; output: true
4. Return true if a word is contained once in a sentence. This is the next step and most natural transition to begin counting instances of a word; input: That dog is happy, dog; output: true
5. Return true if sentence has a word, regardless of capitalization. This spec is almost the same as the previous spec, except that it also considers capitalization of word; input: My cat loves me, my; output: true
6. Recognize how many instances of a word are in a sentence because this is as complex as this program is going to get and is the final requirement in terms of functionality. Also, this is what the user would expect in a final product; input: Biggy biggy bIgGy can't you see, biggy; output: 3

## Setup/Installation Requirements

* _Clone repository from https://github.com/katherinemat/word-counter.git_
* _Run dnx kestrel to start server
* _Go to https://localhost:5004 to open this webpage in browser_
*_Type in sentence and word_
*_Click button to see results_

## Known Bugs

_As is, webpage only checks for whole instances of a word in a text. Project can be improved upon by searching for partial words and by displaying the sentence with the found words highlighted._

## Technologies Used

* _HTML_
* _CSS_
* _Bootstrap_
*_C#_

### License

*This software is licensed under the GPL and MIT licenses.*

Copyright (c) 2017 **_Katherine Matthews_**
