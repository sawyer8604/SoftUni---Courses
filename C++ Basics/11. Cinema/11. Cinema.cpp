#include <iostream>
#include <string>

using namespace std;

int main() {
	string projection;
	int row, columns;
	cin >> projection >> row >> columns;

	cout.setf(ios::fixed);
	cout.precision(2);

	if (projection == "Premiere") {
		cout << row * columns * 12.00 << " leva" << endl;
	}
	else if (projection == "Normal") {
		cout << row * columns * 7.50 << " leva" << endl;
	}
	else if (projection == "Discount") {
		cout << row * columns * 5.00 << " leva" << endl;
	}
	return 0;
}