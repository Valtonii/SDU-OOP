/*

The inner arrays are their own seperate space somewhere in the memory,
where the outer arrays have access to them by storing references to them.
these references would basically point at where the arrays themself are,
in other words, where the rows are in the memory. in an marray, its all
one block and one array, one calculation and one jump

*/
