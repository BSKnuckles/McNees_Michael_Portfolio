// Problem #1 - Stuff Your Face
console.log("Example Problem\nStrawberry Festival Pie Eating Contest\nHeavyweight Division Weight Checker");
let weight = prompt("Please enter the competitor's weight:");
if (isNaN(weight)){
	weight = prompt("Invalid input. Try again:")
}
if (weight >= 250){
	console.log("The competitor qualifies for the heavyweight division.")
}
else if (weight < 250 && weight > 0){
	console.log("The competitor needs to gain some weight!");
}
else if (weight == 0){
	console.log("You entered an invalid value.");
}

// Problem #2 - Free Shipping
console.log("Free Shipping Grocery Calculator");
let items = prompt("How many items are you buying?");
let itemShip = 1.25;
let shipping = items * itemShip;

if (items < 5 && items > 0){
	console.log('Your cost for shipping today for ' + items + ' items is $' + shipping + '.');
}
else if (items >= 5)
{
	console.log("Congratulations! You have bought " + items + " items, so you qualify for free shipping!");
}
else
{
	console.log("You entered an invalid value.");
}

// Problem #3 - Mall Employee Discount
let discount = .9;
console.log("Mall Employee Discount Calculator");
let itemOneCost = Number(prompt("What is the cost of your first item?"));
let itemTwoCost = Number(prompt("What is the cost of your second item?"));
let mallEmployee = prompt("Are you an employee of the mall?");

if (mallEmployee.toUpperCase() == "NO" && itemOneCost != 0 && itemTwoCost != 0)
{
	let nonEmployeeCost = Number(itemOneCost + itemTwoCost).toFixed(2);
	console.log("Your total purchase is $" + nonEmployeeCost + ".");
}
else if (mallEmployee.toUpperCase() == "YES" && itemOneCost != 0 && itemTwoCost != 0)
{
	let nonEmployeeCost = Number(itemOneCost + itemTwoCost).toFixed(2);
	let employeeCost = Number((itemOneCost + itemTwoCost) * discount).toFixed(2);
	console.log("Your total purchase is $" + nonEmployeeCost + "\nbut with your 10% employee discount\nis now $" +  employeeCost);
}
else
{
	console.log("You entered an invalid value.");
}

// Problem #4 - Apple Pickers
console.log("You-Pick Apple Bulk Cost Calculator");
let applesWeight = Number(prompt("How many pounds of apples have you collected?"));
if (applesWeight < 7 && applesWeight > 0)
{
	let costByWeight = 1.00;
	let totalCost = Number(applesWeight * costByWeight).toFixed(2);
	console.log("Your basket of apples of " + applesWeight + " lbs. costs $" + totalCost);
}
else if (applesWeight >= 7 && applesWeight < 15.25)
{
	let costByWeight = .9;
	let totalCost = Number(applesWeight * costByWeight).toFixed(2);
	console.log("Your basket of apples of " + applesWeight + " lbs. costs $" + totalCost);
}
else if (applesWeight >= 15.25 && applesWeight < 50)
{
	let costByWeight = .8;
	let totalCost = Number(applesWeight * costByWeight).toFixed(2);
	console.log("Your basket of apples of " + applesWeight + " lbs. costs $" + totalCost);
}
else if (applesWeight >= 40 && applesWeight < 70.5)
{
	let costByWeight = .7;
	let totalCost = Number(applesWeight * costByWeight).toFixed(2);
	console.log("Your basket of apples of " + applesWeight + " lbs. costs $" + totalCost);
}
else if (applesWeight >= 70.5 && applesWeight <= 100)
{
	let costByWeight = .6;
	let totalCost = Number(applesWeight * costByWeight).toFixed(2);
	console.log("Your basket of apples of " + applesWeight + " lbs. costs $" + totalCost);
}
else if (applesWeight > 100)
{
	let costByWeight = .5;
	let totalCost = Number(applesWeight * costByWeight).toFixed(2);
	console.log("Your basket of apples of " + applesWeight + " lbs. costs $" + totalCost);
}
else{
	console.log("You entered an invalid number.");
}

// Problem #5 - Nerd Out
let standardTicket = 55;
let discountedTicket = 40;
console.log("Comic Con Ticket Price Calculator");
let age = Number(prompt("How old are you?"));
if ((age >= 65 || age < 7) && age > 0)
{
	console.log("Your cost for your ticket to Comic Con is $" + discountedTicket);
}
else
{
	console.log("Your cost for your ticket to Comic Con is $" + standardTicket);
}
