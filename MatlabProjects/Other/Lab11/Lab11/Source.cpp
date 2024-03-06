#include <iostream>
#include "trie.h"

int main() {
    Trie trie;

    std::string directoryPath = "..//MatlabFunctions//";

    if (trie.buildTrie(directoryPath)) {
        std::cout << "Trie built successfully!\n";
    }
    else {
        std::cerr << "Error building Trie.\n";
        return 1;
    }

    std::string wordToSearch = "func";
    std::list<int> fileIDs = trie.searchWord(wordToSearch);

    if (!fileIDs.empty()) {
        std::cout << "The word \"" << wordToSearch << "\" found in the following files:\n";
        for (int fileID : fileIDs) {
            std::cout << "FileID: " << fileID << std::endl;
        }
    }
    else {
        std::cout << "The word \"" << wordToSearch << "\" not found in Trie.\n";
    }

    std::cout << "Trie build time: " << trie.getBuildTime() << " sec.\n";
    std::cout << "Word search time: " << trie.getSearchTime() << " sec.\n";
    std::cout << "Number of words found: " << trie.getWordCount() << std::endl;

    return 0;
}
