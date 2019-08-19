import datetime
import time 
time_tuple = time.localtime(time.time())
while True:
    win_set_time(time_tuple)
    time.sleep(1) # espera 1 segundo

def win_set_time(time_tuple):
    import pywin32
    dayOfWeek = datetime.datetime(time_tuple).isocalendar()[2]
    pywin32.SetSystemTime(time_tuple[:2] + (dayOfWeek,) + time_tuple[2:])
    
#https://pt.stackoverflow.com/q/54321/101
