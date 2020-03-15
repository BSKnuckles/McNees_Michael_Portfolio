// Grocery Calculator
console.log("McNees Grocery Calculator\n--------------------------------------");
let bananaPrice = Number(prompt("Please provide the price for bananas:"));
let beefBrisketPrice = Number(prompt("Please provide the price for a beef brisket:"));
let applePiePrice = Number(prompt("Please provide the price for an apple pie:"));

console.log("Pricing:\nBananas: $" + bananaPrice + "\nBeef Brisket: $" + beefBrisketPrice + "\nApple Pie: $" + applePiePrice);

let qtyBanana = Number(prompt("How many bananas do you wish to purchase?"));
let qtyBrisket = Number(prompt("How many beef briskets do you wish to purchase?"));
let qtyPie = Number(prompt("How many apple pies do you wish to purchase?"));

console.log("Quantity:\nBananas: " + qtyBanana + "\nBeef Brisket: " + qtyBrisket + "\nApple Pie: " + qtyPie);

alert("Confirm your quantities and prices below:\n" + qtyBanana + " banana(s) at $" + bananaPrice + " each\n" + qtyBrisket + " beef brisket(s) at $" + beefBrisketPrice + " each\n" + qtyPie + " apple pie(s) at $" + applePiePrice + " each");

let taxRate = Number(prompt("What is your local tax rate?"));
let salesTax = taxRate / 100;

let totalBananas = qtyBanana * bananaPrice;
let totalBriskets = qtyBrisket * beefBrisketPrice;
let totalPies = qtyPie * applePiePrice;
let subTotal = totalBananas + totalBriskets + totalPies;
let taxTotal = subTotal * salesTax;
let grandTotal = subTotal + taxTotal;

alert(
	"Sales Receipt\n" +
	"Qty\tItem\tExtended Price\n" +
	qtyBanana + "\tBanana(s)\t$" + Number(totalBananas).toFixed(2) + "\n" +
	qtyBrisket + "\tBrisket(s)\t$" + Number(totalBriskets).toFixed(2) + "\n" +
	qtyPie + "\tApple Pie(s)\t$" + Number(totalPies).toFixed(2) + "\n" +
	"Subtotal:    $" + Number(subTotal).toFixed(2) + "\n" +
	"Sales Tax:   $" + Number(taxTotal).toFixed(2) + "\n" +
	"Grand Total: $" + Number(grandTotal).toFixed(2));
