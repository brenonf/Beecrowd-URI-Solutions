n = int(input())

string = ''
for i in range(n):
    string += 'Ho'
    if i == (n-1):
        string += '!'
    else:
        string += ' '
print(string)
