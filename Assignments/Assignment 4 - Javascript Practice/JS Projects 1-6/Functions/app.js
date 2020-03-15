// Problem #1 - Currency Converter
const BuildHeader = function(appName, subHeading){
	console.log(appName +"\n---------------------\n" + subHeading)
};
const ConvertEuroUsDollar = function(input){
	let calculatedValue = input * 1.16;
	return calculatedValue;
};
const PlanetaryWeightConverter = function(weight, rate){
	return weight * rate;
};
const DiscountCalc = function(price, discount){
	return Number(price - (price * (discount / 100))).toFixed(2);
};

BuildHeader("Euro to USD Converter", "Welcome");

let euro = Number(prompt("Please enter an amount in EUR to convert to USD:"));
while (isNaN(euro)){
	BuildHeader("Euro to USD Converter", "Try Again");
	euro = Number(prompt("Please only type in numbers and do not leave blank.\\nPlease enter an amount in EUR to convert to USD:"));
}
BuildHeader("Euro to USD Converter", "Results");
let converted = Number(ConvertEuroUsDollar(euro)).toFixed(2);
console.log("€" + euro + " converted to USD is $" + converted);

// Problem #2 - Astronomical
BuildHeader("Astronomical Weight Converter", "Welcome");

let weightOnEarth = Number(prompt("Please enter your weight on Earth"));
while (isNaN(weightOnEarth)){
	BuildHeader("Astronomical Weight Converter", "Try Again");
	console.log("Please only type in numbers and do not leave blank.");
	weightOnEarth = Number(prompt("Please enter your weight on Earth"));
}
BuildHeader("Astronomical Weight Converter", "Planet Choice");
let planetChoice = Number(prompt("Please enter the number of the planet you wish to convert your weight to:\n1: Mercury\n2: Venus\n3: Earth\n4: Mars\n5: Jupiter\n6: Saturn\n7: Uranus\n8: Neptune"));
while (isNaN(planetChoice) || planetChoice <= 0 || planetChoice > 8)
{
	BuildHeader("Astronomical Weight Converter", "Try Again");
	planetChoice = Number(prompt("Please enter a number between 1 and 8 corresponding to your planet choice:\n1: Mercury\n2: Venus\n3: Earth\n4: Mars\n5: Jupiter\n6: Saturn\n7: Uranus\n8: Neptune"));
}
BuildHeader("Astronomical Weight Converter", "Calculated Results");
if (planetChoice == 1)
{
	console.log("On Earth you weight " + weightOnEarth +  " lbs, but on Mercury you would weigh " + PlanetaryWeightConverter(weightOnEarth, .38) + " lbs.");
}
else if (planetChoice == 2)
{
	console.log("On Earth you weight " + weightOnEarth +  " lbs, but on Venus you would weigh " + PlanetaryWeightConverter(weightOnEarth, .91) + " lbs.");
}
else if (planetChoice == 3)
{
	console.log("On Earth you weight " + weightOnEarth +  " lbs, and on Earth you would still weigh " + PlanetaryWeightConverter(weightOnEarth, 1) + " lbs.");
}
else if (planetChoice == 4)
{
	console.log("On Earth you weight " + weightOnEarth +  " lbs, but on Mars you would weigh " + PlanetaryWeightConverter(weightOnEarth, .38) + " lbs.");
}
else if (planetChoice == 5)
{
	console.log("On Earth you weight " + weightOnEarth +  " lbs, but on Jupiter you would weigh " + PlanetaryWeightConverter(weightOnEarth, 2.34) + " lbs.");
}
else if (planetChoice == 6)
{
	console.log("On Earth you weight " + weightOnEarth +  " lbs, but on Saturn you would weigh " + PlanetaryWeightConverter(weightOnEarth, .93) + " lbs.");
}
else if (planetChoice == 7)
{
	console.log("On Earth you weight " + weightOnEarth +  " lbs, but on Uranus you would weigh " + PlanetaryWeightConverter(weightOnEarth, .92) + " lbs.");
}
else if (planetChoice == 8)
{
	console.log("On Earth you weight " + weightOnEarth +  " lbs, but on Neptune you would weigh " + PlanetaryWeightConverter(weightOnEarth, 1.12) + " lbs.");
}
else
{
	console.log("You did not enter a valid value.");
}

// Problem #3 - Dramatic Discounts
let discounts = [5, 10, 15, 20, 25, 30];
BuildHeader("Discount Calculator", "Welcome");

let itemPrice = Number(prompt("Please enter the price of an item:"));
while (isNaN(itemPrice)){
	BuildHeader("Discount Calculator", "Try Again");
	itemPrice = Number(prompt("The price should contain numbers only.\nPlease enter the price of an item:"));
}
BuildHeader("Discount Calculator", "Calculated Discounts");
for (let i = 0; i < discounts.length; i++)
{
	let discountedPrice = DiscountCalc(itemPrice, discounts[i]);
	console.log("$" + itemPrice + " with a " + discounts[i] + "% discount is $" + discountedPrice + ".");
}
