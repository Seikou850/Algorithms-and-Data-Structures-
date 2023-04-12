//
//  main.cpp
//  Task C Assessed Exercise 2
//
//  Created by Seikou Bah Karagera on 12/01/2023.
//

#include <iostream>
#include <string>

void DNAreverse(std::string S, std::string Y, std::string L, std::string R) {
    int count = 0;

    std::int64_t index = S.find(L + Y + R);
    while (index != -1) {
        std::string reversedY = std::string(Y.rbegin(), Y.rend());
        S.replace(index + L.length(), Y.length(), reversedY);
        count++;
        index = S.find(L + Y + R);
    }

    std::cout << S << std::endl;
    std::cout << "The number of occurrences of " << L + Y + R << " is: " << count << std::endl;
}

int main() {
    DNAreverse("ATAGGTAGGGATAGGTTAG", "TAG", "A", "GT");
}


