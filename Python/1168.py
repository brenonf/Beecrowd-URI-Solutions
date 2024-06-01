n = int(input())



for j in range(1,n+1):
    led = 0
    x = input()
    for i in range(0,len(x)):
        if x[i] == '1':
            led = led + 2
        if x[i] == '2':
            led = led + 5
        if x[i] == '3':
            led = led + 5
        if x[i] == '4':
            led = led + 4
        if x[i] == '5':
            led = led + 5
        if x[i] == '6':
            led = led + 6
        if x[i] == '7':
            led = led + 3
        if x[i] == '8':
            led = led + 7
        if x[i] == '9':
            led = led + 6
        if x[i] == '0':
            led = led + 6
    print('{} leds'.format(led))
