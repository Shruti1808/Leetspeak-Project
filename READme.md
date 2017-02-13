The user enters a string of words.
# If the entered word doesn't contains {"e", "E", "o", "O", "I", "s", "S" }, then return the word as it is.
eg, input: attack  output :attack

# if phrase contains "e" or "E", replace it with "3";
eg,  input: "leet" output:"l33t"

# if phrase contains "o" or "O", replace it with  "0"
 eg, input: son output :s0n

# if phrase contains "I" replace it with "1"
 eg. input: pIck output:p1ck

#replace "s" with "z" if not in first letter position
eg, input: asset output: azz3t

#translate sentence using above rules
eg, input: "Do you love these 'String' exercises? I do!"
output: "D0 y0u l0v3 th3z3 'String' 3x3rciz3z? 1 d0!"

#leave special characters like punctuation and numbers alone
eg, input: "don't"
output: "d0n't"
