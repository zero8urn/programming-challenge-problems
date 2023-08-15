package main

import "fmt"

func main() {
    fmt.Println("Hello, world!!")

    var _ int = 0
    var _ float64 = 1.1
    var _ string = "Hello"
    var _ bool = true
    var _  byte = 2
    var _ rune = 'a'

    RomanToInt(); 
    // make vs new
    // := vs =
      // https://www.geeksforgeeks.org/difference-between-var-keyword-and-short-declaration-operator-in-golang/

}
