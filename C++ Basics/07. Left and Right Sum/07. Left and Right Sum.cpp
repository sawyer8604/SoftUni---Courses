#include <iostream>
#include <cmath>

using namespace std;

int main() {

	int n, leftSum = 0, rightSum = 0;
	cin >> n;


	for (int i = 0; i < n; i++) {
		int numbers;
		cin >> numbers;
		leftSum += numbers;
	}
	for (int i = 0; i < n; i++) {
		int numbers;
		cin >> numbers;
		rightSum += numbers;


	}

	if (leftSum == rightSum) {
		cout << "Yes, sum = " << leftSum << endl;
	}
	else {
		int dif = abs(rightSum - leftSum);
		cout << "No, diff = " << dif << endl;
	}

	return 0;
}