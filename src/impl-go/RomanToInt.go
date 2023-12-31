package main

import "fmt"

func RomanToInt() {
	// s := "LVIII"
	s := "MCMXCIV"
	result := 0

	fmt.Println("Calc me daddy")

	inputs := []rune(s)

	for i := 0; i < len(inputs); i++ {
		//fmt.Printf("char: %v\n", inputs[i])
		currentVal := lookupRomanValue(inputs[i])
		fmt.Printf("int: %v\n", currentVal)

		nextVal := 0

		if i+1 < len(inputs) {
			nextVal = lookupRomanValue(inputs[i+1])
		}

		if nextVal > currentVal {
			result = result + (nextVal - currentVal)
			i++
		} else {
			result += currentVal
		}
	}

	fmt.Printf("Input: %v : Output: %v\n", s, result)
}

func lookupRomanValue(val rune) int {
	switch val {
	case 'I':
		return 1
	case 'V':
		return 5
	case 'X':
		return 10
	case 'L':
		return 50
	case 'C':
		return 100
	case 'D':
		return 500
	case 'M':
		return 1000
	default:
		return 0
	}
}
