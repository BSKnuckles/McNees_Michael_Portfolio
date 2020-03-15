// Lists Project

const addLocation = function(){
	let location = prompt("Where would you like to visit?");
	while (location.length === 0 || location === " "){
		location = prompt("This cannot be blank.\nPlease name a vacation destination you would like to visit this year:");
	}
	return location;
};
const tripOutput = function(locations){
	console.log("You will make " + locations.length + " trip(s) this year.")
	for (let i = 0; i < locations.length; i++){
		console.log("You will visit " + locations[i] + " this year.")
	}
	console.log("Thank you for using the program and safe travels!")
}
let locations = [];

let locationNumber = 1;
console.log("Vacation Destination Planner\n----------------------------\nAdd location #" + locationNumber);

let firstLocation = prompt("Please name a vacation destination you would like to visit this year:");

while (firstLocation.length === 0 || firstLocation === " "){
	firstLocation = prompt("This cannot be blank.\nPlease name a vacation destination you would like to visit this year:");
}

locations.push(firstLocation);

let nextLocation = prompt("Would you like to add any additional vacation locations? Please enter 'Yes' or 'No'.");

while (nextLocation.toUpperCase() !== "YES" && nextLocation.toUpperCase() !== "NO"){
	nextLocation = prompt("\"" + nextLocation + "\" is not a valid answer.\nPlease enter only 'Yes' or 'No':")
}

while (nextLocation.toUpperCase() === "YES"){
	locations.push(addLocation());

	nextLocation = prompt("Would you like to add any additional vacation locations? Please enter 'Yes' or 'No'.");
}

tripOutput(locations);
