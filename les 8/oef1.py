tpl = (('a', 21),('b', 35),('c', 17), ('d',24))
list_tpl = list(tpl)

list_tpl.sort(key = lambda x: x[1], reverse=True)
sorted_tpl = tuple(list_tpl)

print(sorted_tpl)