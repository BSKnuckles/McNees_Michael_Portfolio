// Shirt Sizes Project

console.log("Welcome to the Shirt Order calculator.\nThis app will determine the number of\nshirts you need to buy in each size available.");

let shirtOrder = ["Medium", "Small", "X-Large", "Small", "Large", "Medium", "Small", "X-Large", "XX-Large"];
// let shirtOrder = ["XX-Large", "Medium", "Large", "Small", "X-Large", "Small", "Large", "XX-Large", "Large", "XX-Large", "Medium", "Medium"];

let small = 0, medium = 0, large = 0, xlarge = 0, xxlarge = 0;

for (let i = 0; i < shirtOrder.length; i++){
	let size = shirtOrder[i];
	if (size === "Small") {
		small++;
	}
	else if (size === "Medium") {
		medium++;
	}
	else if (size === "Large") {
		large++;
	}
	else if (size === "X-Large") {
		xlarge++;
	}
	else if (size === "XX-Large") {
		xxlarge++;
	}
	else {
		console.log("Some error occurred. It's probably Mike's fault.");
	}
}

alert(
	"Order " + small + " small shirts.\n" +
	"Order " + medium + " medium shirts.\n" +
	"Order " + large + " large shirts.\n" +
	"Order " + xlarge + " x-large shirts.\n" +
	"Order " + xxlarge + " xx-large shirts.");
