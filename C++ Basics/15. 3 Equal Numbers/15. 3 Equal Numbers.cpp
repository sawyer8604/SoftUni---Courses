#include <iostream>

using namespace std;

int main() {
	int num1, num2, num3;
	cin >> num1;
	cin >> num2;
	cin >> num3;

	if (num1 == num2) {

		if (num1 == num3) {
			cout << "yes" << "\n";
		}
		else {
			cout << "no" << "\n";
		}
	}
	else {
		cout << "no" << "\n";
	}

	return 0;
}