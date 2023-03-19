#include <iostream>
#include <string>

using namespace std;

int main() {

	string month;
	cin >> month;

	int nights;
	cin >> nights;

	cout.setf(ios::fixed);
	cout.precision(2);

	double studioPrice = 0;
	double apartamentPrice = 0;
	double studioRent = 0;
	double apartamentRent = 0;

	if (month == "May" || month == "October") {
		studioPrice = 50;
		apartamentPrice = 65;

		if (nights > 14) {
			studioPrice *= 0.7;
			apartamentPrice *= 0.9;

		}
		else if (nights > 7) {
			studioPrice *= 0.95;
		}

	}
	else if (month == "June" || month == "September") {
		studioPrice = 75.20;
		apartamentPrice = 68.70;

		if (nights > 14) {
			studioPrice *= 0.8;
			apartamentPrice *= 0.9;
		}

	}
	else if (month == "July" || month == "August") {
		studioPrice = 76;
		apartamentPrice = 77;


		if (nights > 14) {
			apartamentPrice *= 0.9;
		}
	}

	cout << "Apartment: " << apartamentPrice * nights << " lv." << endl;
	cout << "Studio: " << studioPrice * nights << " lv." << endl;
	return 0;
}