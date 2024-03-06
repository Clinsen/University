#include "trie.h"
#include <ctime>
#include <iostream>

Trie::Trie() : root(nullptr), buildTime(0.0f), searchTime(0.0f), wordCount(0) {}

Trie::~Trie() {
}

TrieNode* Trie::getNewNode() {
    return new TrieNode();
}

void Trie::insertWord(const std::string& word, int fileID) {
    TrieNode* current = root ? root : (root = getNewNode());

    for (char c : word) {
        if (current->children.find(c) == current->children.end())
            current->children[c] = getNewNode();
        current = current->children[c];
        current->count++;
    }

    current->fileIDs.push_back(fileID);
}

bool Trie::buildTrie(const std::string& directoryPath) {
    clock_t start = clock();

    for (int i = 0; i < 100001; ++i) {
        std::string filename = directoryPath + std::to_string(i) + ".txt";
        std::ifstream file(filename);
        std::string word;
        while (file >> word)
            insertWord(word, i);
    }

    clock_t end = clock();
    buildTime = static_cast<float>(end - start) / CLOCKS_PER_SEC;

    return true;
}

std::list<int> Trie::searchWord(const std::string& word) {
    clock_t start = clock();

    TrieNode* current = root;
    for (char c : word) {
        if (current && current->children.find(c) != current->children.end())
            current = current->children[c];
        else
            return {};
    }

    clock_t end = clock();
    searchTime = static_cast<float>(end - start) / CLOCKS_PER_SEC;
    wordCount = current->count;

    return current->fileIDs;
}

float Trie::getBuildTime() const {
    return buildTime;
}

float Trie::getSearchTime() const {
    return searchTime;
}

int Trie::getWordCount() const {
    return wordCount;
}
