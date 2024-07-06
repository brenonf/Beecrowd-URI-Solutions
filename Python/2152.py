n = int(input())
for i in range(n):
    h,m,o = map(str,input().split())
    if int(o) == 1:
        o = 'abriu'
    else:
        o = 'fechou'
    if len(m) == 1:
        m = '0' + m
    if len(h) == 1:
        h = '0' + h
    print('{}:{} - A porta {}!'.format(h,m,o))  
