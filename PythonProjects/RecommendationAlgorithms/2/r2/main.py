import pandas as pd

recommendations = pd.DataFrame()

df = pd.read_excel('lab2.xlsx')
df = df.astype(str)

df = df.set_index("Object").T
df.to_excel('DataSet.xlsx')

df = pd.read_excel('DataSet.xlsx', index_col=0)
recList = []

for row in df:
    print(row)
    k = 0
    corrMatr = df.corrwith(df[row])
    corrMatr = pd.DataFrame(corrMatr)
    tempMatr = corrMatr
    tempMatr = tempMatr.drop([row], axis=0)

    while k != 1:
        name = tempMatr.idxmax().item()
        value = tempMatr[0][tempMatr.idxmax().item()]
        recList.append([row, name, value])
        tempMatr = tempMatr.drop([tempMatr.idxmax().item()], axis=0)
        k += 1

recommendations = pd.concat([recommendations, pd.DataFrame(recList)], ignore_index=True)

recommendations.columns = ['Джерело', 'Рекомендація', 'Індекс кореляції']
recommendations = recommendations.sort_values(by='Індекс кореляції', ascending=False)

recommendations.to_excel('result.xlsx', index=False)
