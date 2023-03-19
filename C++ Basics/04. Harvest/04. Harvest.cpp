#include <iostream>
#include <cmath>

using namespace std;

int main() {

	double vineyarAres;
	double grapePerSquare;
	double needetLitres;
	int workers;

	cin >> vineyarAres >> grapePerSquare >> needetLitres >> workers;

	double harvestPerWine = vineyarAres * 0.4 * grapePerSquare;
	double wine = harvestPerWine / 2.5;

	if (wine > needetLitres) {

		double totalWine = floor(wine);
		double litresLeft = ceil(wine - needetLitres);
		double litresPerPerson = ceil((wine - needetLitres) / workers);

		cout << "Good harvest this year! Total wine: " << totalWine << " liters." << endl;
		cout << litresLeft << " liters left -> " << litresPerPerson << " liters per person." << endl;
	}
	else {
		double litresNeedet = floor(needetLitres - wine);
		cout << "It will be a tough winter! More " <<
			litresNeedet << " liters wine needed." << endl;

	}
	return 0;
}