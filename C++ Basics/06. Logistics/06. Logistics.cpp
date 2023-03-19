#include <iostream>
#include <cmath>
#include <iomanip>

using namespace std;

int main() {

	int n;
	cin >> n;

	double sumMikrobus = 0, sumTir = 0, sumtrain = 0, allSum = 0;
	double percentMikrobus = 0, percentTir = 0, percentTrain = 0;
	double avaragePricePerTon = 0;

	cout.setf(ios::fixed);
	cout.precision(2);

	for (int i = 0; i < n; i++) {

		int ton;
		cin >> ton;

		if (ton <= 3) {

			sumMikrobus += ton;

		}
		if (ton > 3 && ton <= 11) {
			;
			sumTir += ton;

		}
		if (ton > 11) {

			sumtrain += ton;

		}
	}


	allSum = sumMikrobus + sumTir + sumtrain;

	avaragePricePerTon = (sumMikrobus * 200 + sumTir * 175 + sumtrain * 120) / allSum;

	percentMikrobus = sumMikrobus / allSum * 100;
	percentTir = sumTir / allSum * 100;
	percentTrain = sumtrain / allSum * 100;


	cout << avaragePricePerTon << endl;
	cout << percentMikrobus << "%" << endl;
	cout << percentTir << "%" << endl;
	cout << percentTrain << "%" << endl;

	return 0;
}