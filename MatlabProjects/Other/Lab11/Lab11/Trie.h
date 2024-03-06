#ifndef TRIE_H
#define TRIE_H

#include <string>
#include <list>
#include <fstream>
#include <unordered_map>

struct TrieNode {
    std::list<int> fileIDs;
    int count;
    std::unordered_map<char, TrieNode*> children;

    TrieNode() : count(0) {}
};

class Trie {
private:
    TrieNode* root;
    float buildTime;
    float searchTime;
    int wordCount;

    void insertWord(const std::string& word, int fileID);
    TrieNode* getNewNode();

public:
    Trie();
    ~Trie();
    bool buildTrie(const std::string& directoryPath);
    std::list<int> searchWord(const std::string& word);
    float getBuildTime() const;
    float getSearchTime() const;
    int getWordCount() const;
};

#endif // TRIE_H
