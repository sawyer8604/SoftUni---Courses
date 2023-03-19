#include <iostream>
#include <cmath>
#include <iomanip>

using namespace std;

int main() {

	double heritMoney;
	int yearToLive;

	cin >> heritMoney >> yearToLive;

	int yearsOld = 18;


	for (int i = 1800; i <= yearToLive; i++) {

		if (i % 2 == 0) {
			heritMoney -= 12000;
		}
		else {
			heritMoney -= 12000 + 50 * yearsOld;
		}
		yearsOld++;
	}
	cout.setf(ios::fixed);
	cout.precision(2);

	if (heritMoney >= 0) {

		cout << "Yes! He will live a carefree life and will have " << heritMoney << " dollars left. " << endl;
	}
	else {

		cout << "He will need " << abs(heritMoney) << " dollars to survive. " << endl;
	}
	return 0;
}