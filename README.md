# datastruct-module
ed1.analyze and represent the nature, structure and utility of fundamental data types
1.1 describe and represent the general nature of static data structures including:

1.1.1 how data structures are stored in memory
Data structures are generally based on the ability of a computer to fetch and store data at any place in its memory, specified by a pointer—a bit string, representing a memory address, that can be itself stored in memory and manipulated by the program.

 1.1.2 the advantages and disadvantages of fundamental data structures in relation to primitive data types
Non-primitive data structure can consist of a NULL value.
In case of non-primitive data structure, size is not fixed.
Primitive data structure can be used to call the methods.

 1.1.3 the advantages and disadvantages of the various fundamental data structures
Boolean, which stores logical values that are either true or false.
integer, which stores a range of mathematical integers -- or counting numbers. Different sized integers hold a different range of values -- e.g., a signed 8-bit integer holds values from -128 to 127, and an unsigned long 32-bit integer holds values from 0 to 4,294,967,295.
Floating-point numbers, which store a formulaic representation of real numbers.
Fixed-point numbers, which are used in some programming languages and hold real values but are managed as digits to the left and the right of the decimal point.
Character, which uses symbols from a defined mapping of integer values to symbols.
Pointers, which are reference values that point to other values.
String, which is an array of characters followed by a stop code -- usually a "0" value -- or is managed using a length field that is an integer value.
1.2 describe and represent the nature and mechanics of basic data structures including:
 
 1.2.1 the static array including: use of cells to store data, data homogeneity, use of an index (or indices) to identify the location of data elements, types; e.g., single dimensional arrays (lists), double dimensional arrays (tables) and parallel arrays (look-up or associative tables)

-An array is a collection of items of the same data type at adjacent locations. This makes calculating the position of each bit of data easy as you use the index to offset the search from the original data point. Multi-dimensional arrays aren’t arrays with just two indexes, but an array of arrays, looking through one array to find another array. Have preset sizes that get filled up.

 1.2.2 the record including: the use of fields to store data, data heterogeneity, the use of field names to identify the location of data elements.

-Records in a database or spreadsheet are usually called "rows". A record is a collection of fields, possibly of different data types, typically in a fixed number and sequence.A record is a collection of fields, possibly of different data types, typically in a fixed number and sequence.
 1.2.3 the dynamic array including: sizes, types; e.g., single dimensional arrays (lists), double dimensional arrays (tables) and parallel arrays (look-up or associative tables)

-dynamic arrays work by making a static array, and when that static array becomes full, it creates a new array double its original size and re-adds the old array to it. I imagine that a multi-dimensional dynamic array works the same ways as any multi dimensional array.
1.3 describe and represent the operations associated with data structures including:
 1.3.1 creating the structure
-To make a list in C#, you need to use the System.Collections.Generic namespace to use them, and we create one by specifying List<T>, where T is a restriction(like a data type), and then setting a name, then setting it e	qual to new List<T>();
Ex.
	List<int> numbers = new List<int>();

 1.3.2 inserting, deleting and replacing data in the structure
With C#, there isn’t a way to replace a point in the list, but you can add and remove using insert, remove and RemoveAt. Remove compares all the items of the list to see if it equals the item you want to remove and removes it, it does not remove by index but by the data stored

Insert:
	numbers.Insert(index,stored item);
Remove:
	numbers.Remove(10);  (removes the first 10 from a list)

RemoveAt:
	numbers.RemoveAt(2); (removes the 3rd element, since it starts at 0)

 1.3.3 searching, finding and retrieving data from the structure
You can search through a list by iterating through it with a loop and calling each item one by one and comparing them, albeit slow, it really is the only way.
Ex.
Find and print the number 5 in the list numbers
for(int i = 0; i < numbers.Count; i++)
	if(number[i] == 5)
		console.WriteLine(numbers[i]) 
1.3.4 determining the size of the structure
You can add .count to the end of the list to get the length of the list.
Ex. 
	numbers.count

 1.3.5 copying the structure
You can use CopyTo() method to copy one list to another.
Ex.
numbers.CopyTo(numbers_2)

 1.3.6 comparing two structures of the same type
If you want to compare lists, you can do either the variable type it stores,the contents of the lists, or how long it is. To get the variable type of a list you can use the GetType() method. For finding length, we can use the .Count property of lists. If you want to compare the contents of lists with each other, you have to iterate through both lists comparing each item at each index.
