lst = ["123", "2", "abc", ":)", "!"]
size = len(lst)
while size > 3:
    del lst[0]
    size -= 1
else:
    print(lst)