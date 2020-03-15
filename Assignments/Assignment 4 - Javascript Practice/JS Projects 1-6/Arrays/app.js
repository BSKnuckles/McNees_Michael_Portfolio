// Problem #1 - Book Buyer
console.log("Book Buyer Calculator");
let numBooks = Number(prompt("How many books would you like to buy?"));
while(isNaN(numBooks) || numBooks < 1){
	console.log("Please enter a valid number of books.");
	numBooks = Number(prompt("It must be greater than 0 and not written in letters.:"));
}
let books = [];
for (let i = 0; i < numBooks; i++)
{
	let bookCost = Number(prompt("What is the cost of book #" + (i+1) + "?"));
	while (isNaN(bookCost))
	{
		bookCost = Number(prompt("Invalid entry. What is the cost of book #" + i +  "?"));
	}
	books[i] = bookCost;
}
let booksTotal = 0;
for (let j = 0; j < numBooks; j++)
{
	booksTotal += books[j];
}
console.log("Your total cost for " + numBooks + " book(s) is $" + booksTotal);

// Problem #2 - Coloring Outside the Lines
let randomThings = ["grapes", "apples", "limes", "lemons"];
let colors = ["purple", "red", "green", "yellow"];
let randomThingsTwo = ["ball", "carrot", "towel", "laptop", "stove"];
let colorsTwo = ["red", "orange", "white", "silver", "black"];

console.log("Arrays Test #1");
for (let i = 0; i <= randomThings.length-1; i++){
	console.log("THe main color of " + randomThings[i] + " is " + colors[i]);
}

console.log("Arrays Test #2");
for (let i = 0; i <= randomThingsTwo.length-1; i++){
	console.log("THe main color of " + randomThingsTwo[i] + " is " + colorsTwo[i]);
}
