Console.WriteLine("Hello World!");
// 7.3 Array Type
// An array's type is built from its element type plus [].
//   int[]    -> every element is an int
//   string[] -> every element is a string
// The element type is fixed when the array is declared.
// Every slot must hold that type, and the compiler enforces it:
//   int[] a = new int[3];
//   a[0] = "hi";   // compile error: string can't go in an int slot
// So the array type tells you exactly what you get back
// when you read a slot: a[0] is an int, no guessing.
// TODO: say this out loud in my own words next session.
