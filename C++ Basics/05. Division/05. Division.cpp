#include <iostream>
#include <iomanip>
#include <cmath>

using namespace std;

int main() {

	int n;
	cin >> n;

	double divisedBy2 = 0, divisedBy3 = 0, divisedBy4 = 0;
	double percent2 = 0, percent3 = 0, percent4 = 0;

	cout.setf(ios::fixed);
	cout.precision(2);

	for (int i = 0; i < n; i++) {

		int num;
		cin >> num;


		if (num % 2 == 0) {

			divisedBy2++;
			percent2 = (divisedBy2 / n) * 100.0;
		}
		if (num % 3 == 0) {

			divisedBy3++;
			percent3 = (divisedBy3 / n) * 100.0;
		}
		if (num % 4 == 0) {

			divisedBy4++;
			percent4 = (divisedBy4 / n) * 100.0;
		}


	}

	cout << percent2 << "%" << endl;
	cout << percent3 << "%" << endl;
	cout << percent4 << "%" << endl;

	return 0;
}