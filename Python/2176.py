s = input()
if s.count('1') % 2 == 0:
    s += '0'
else:
    s += '1'

print(s)
