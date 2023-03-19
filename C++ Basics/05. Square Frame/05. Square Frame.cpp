#include <iostream>

using namespace std;

int main() {

	int n;
	cin >> n;

	cout << "+";

	for (int i = 0; i < n - 2; i++) {

		cout << " -";

	}
	cout << " +" << endl;

	for (int j = 0; j < n - 2; j++) {
		cout << "|";

		for (int k = 0; k < n - 2; k++) {

			cout << " -";
		}
		cout << " |" << endl;
	}
	cout << "+";

	for (int l = 0; l < n - 2; l++) {

		cout << " -";

	}
	cout << " +" << endl;



	return 0;
}