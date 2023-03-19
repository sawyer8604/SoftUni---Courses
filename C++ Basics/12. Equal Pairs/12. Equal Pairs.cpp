#include <iostream>
#include <cmath>

using namespace std;

int main() {

	int n;
	cin >> n;

	int previousSum = 0, currentSum = 0, difference = 0;

	for (int i = 1; i <= n; i++) {



		if (i == 1) {
			int firstNum, secondNum;
			cin >> firstNum >> secondNum;

			previousSum = firstNum + secondNum;

		}

		else {
			int firstNum2, secondNum2;

			cin >> firstNum2 >> secondNum2;

			currentSum = firstNum2 + secondNum2;
			if (abs(previousSum - currentSum) > difference) {
				difference = abs(currentSum - previousSum);
			}
			previousSum = currentSum;
		}

	}


	if (difference > 0) {

		cout << "No, maxdiff= " << difference << endl;
	}
	else {

		cout << "Yes, value= " << previousSum << endl;

	}

	return 0;
}