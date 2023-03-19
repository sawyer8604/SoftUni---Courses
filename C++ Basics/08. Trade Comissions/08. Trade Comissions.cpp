#include <iostream>
#include <string>

using namespace std;

int main() {
	string town;
	double sales;
	cin >> town >> sales;
	double comissions = -1;

	cout.setf(ios::fixed);
	cout.precision(2);

	if (town == "Sofia") {

		if (0 <= sales && sales <= 500) {
			comissions = 0.05;
			cout << sales * comissions << endl;
		}
		else if (sales > 500 && sales <= 1000) {
			comissions = 0.07;
			cout << sales * comissions << endl;
		}
		else if (sales > 1000 && sales <= 10000) {
			comissions = 0.08;
			cout << sales * comissions << endl;
		}
		else if (sales > 10000) {
			comissions = 0.12;
			cout << sales * comissions << endl;
		}
		else {
			cout << "error" << endl;
		}
	}
	else if (town == "Varna") {
		if (0 <= sales && sales <= 500) {
			comissions = 0.045;
			cout << sales * comissions << endl;
		}
		else if (sales > 500 && sales <= 1000) {
			comissions = 0.075;
			cout << sales * comissions << endl;
		}
		else if (sales > 1000 && sales <= 10000) {
			comissions = 0.1;
			cout << sales * comissions << endl;
		}
		else if (sales > 10000) {
			comissions = 0.13;
			cout << sales * comissions << endl;
		}
		else {
			cout << "error" << endl;
		}
	}
	else if (town == "Plovdiv") {
		if (0 <= sales && sales <= 500) {
			comissions = 0.055;
			cout << sales * comissions << endl;
		}
		else if (sales > 500 && sales <= 1000) {
			comissions = 0.08;
			cout << sales * comissions << endl;
		}
		else if (sales > 1000 && sales <= 10000) {
			comissions = 0.12;
			cout << sales * comissions << endl;
		}
		else if (sales > 10000) {
			comissions = 0.145;
			cout << sales * comissions << endl;
		}
		else {
			cout << "error" << endl;
		}

	}
	else {
		cout << "error" << endl;
	}



	return 0;
}