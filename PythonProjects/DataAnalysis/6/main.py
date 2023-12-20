from itertools import combinations

def generate_candidates(prev_candidates, k):
    candidates = set()
    for itemset1 in prev_candidates:
        for itemset2 in prev_candidates:
            union_set = itemset1.union(itemset2)
            if len(union_set) == k:
                candidates.add(union_set)
    return candidates

def prune_infrequent(itemsets, transactions, min_support):
    frequent_itemsets = set()
    item_counts = {}

    for transaction in transactions:
        for itemset in itemsets:
            if itemset.issubset(transaction):
                item_counts[itemset] = item_counts.get(itemset, 0) + 1

    for itemset, count in item_counts.items():
        support = count / len(transactions)
        if support >= min_support:
            frequent_itemsets.add(itemset)

    return frequent_itemsets

def apriori(transactions, min_support):
    transactions = [set(transaction) for transaction in transactions]
    itemsets = [frozenset([item]) for item in set.union(*transactions)]
    k = 2
    frequent_itemsets = set()

    while itemsets:
        candidates = generate_candidates(itemsets, k)
        frequent_itemsets.update(prune_infrequent(candidates, transactions, min_support))
        itemsets = candidates
        k += 1

    return frequent_itemsets

# Задані дані
data = {
    'T1': {'A', 'B', 'C'},
    'T2': {'A', 'B', 'C', 'D', 'E'},
    'T3': {'A', 'C'},
    'T4': {'A', 'C', 'D', 'E'},
    'T5': {'A', 'B', 'C', 'D'}
}

transactions = list(data.values())
min_support = 0.4

frequent_itemsets = apriori(transactions, min_support)
print("Часті набори об'єктів:")
for itemset in frequent_itemsets:
    print(itemset)
