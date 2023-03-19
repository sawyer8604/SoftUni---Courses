#include <iostream>
#include <climits>
using namespace std;
int main()
{

    int number;
    cin >> number;

    double even_sum{ 0 };
    double odd_sum{ 0 };

    double even_min_number{ 1000000000.0 };
    double odd_min_number{ 1000000000.0 };
    double even_max_number{ -1000000000.0 };
    double odd_max_number{ -1000000000.0 };

    for (int i = 1; i <= number; i++)
    {
        double current_number;
        cin >> current_number;

        if (i % 2 == 0)
        {
            even_sum += current_number;
        }
        else
        {
            odd_sum += current_number;
        }
        if (current_number < even_min_number && i % 2 == 0)
        {
            even_min_number = current_number;
        }
        else if (current_number < odd_min_number && i % 2 != 0)
        {
            odd_min_number = current_number;
        }
        if (current_number > even_max_number && i % 2 == 0)
        {
            even_max_number = current_number;
        }
        else if (current_number > odd_max_number && i % 2 != 0)
        {
            odd_max_number = current_number;
        }
    }

    cout << "OddSum=" << odd_sum << ',' << endl;
    if (odd_min_number == 1000000000.0)
    {
        cout << "OddMin=" << "No" << ',' << endl;
    }
    else
    {
        cout << "OddMin=" << odd_min_number << ',' << endl;
    }

    if (odd_max_number == -1000000000.0)
    {
        cout << "OddMax=" << "No" << ',' << endl;
    }
    else
    {
        cout << "OddMax=" << odd_max_number << ',' << endl;
    }

    cout << "EvenSum=" << even_sum << ',' << endl;

    if (even_min_number == 1000000000.0)
    {
        cout << "EvenMin=" << "No" << ',' << endl;
    }
    else
    {
        cout << "EvenMin=" << even_min_number << ',' << endl;
    }

    if (even_max_number == -1000000000.0)
    {
        cout << "EvenMax=" << "No" << ',' << endl;
    }
    else
    {
        cout << "EvenMax=" << even_max_number << ',' << endl;
    }

    return 0;
}