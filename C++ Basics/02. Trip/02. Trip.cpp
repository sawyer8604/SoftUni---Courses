#include <iostream>
#include <string>
#include <iomanip>

using namespace std;

int main() {

	double budget;
	cin >> budget;
	string season;
	cin >> season;

	cout.setf(ios::fixed);
	cout.precision(2);

	string destinationResult, holidayInformation, restingPlace;
	double moneySpent = 0;

	if (budget <= 100) {
		destinationResult = "Bulgaria";
		if (season == "summer") {
			moneySpent = 0.3 * budget;
			restingPlace = "Camp";
		}
		else {
			moneySpent = 0.7 * budget;
			restingPlace = "Hotel";
		}
	}
	else if (budget <= 1000) {
		destinationResult = "Balkans";

		if (season == "summer") {
			moneySpent = 0.4 * budget;
			restingPlace = "Camp";
		}
		else {
			moneySpent = 0.8 * budget;
			restingPlace = "Hotel";
		}
	}
	else {
		destinationResult = "Europe";
		moneySpent = 0.9 * budget;
		restingPlace = "Hotel";
	}
	cout << "Somewhere in " << destinationResult << endl;
	cout << restingPlace << " - " << moneySpent << endl;


	return 0;
}