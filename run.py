from tkinter import *
import tkinter as tk
import pyttsx3

engine = pyttsx3.init()
voices = engine.getProperty('voices')
engine.setProperty('voice', voices[1].id)
volume= engine.getProperty('rate') 
engine.setProperty('rate', 200)
def speak():
    engine.say(listen.get())
    engine.runAndWait()
    engine.stop()

root = Tk()
listen = StringVar()
root.title("Chuyển văn bản thành giọng nói")
root.geometry("450x350")

outside = LabelFrame(root,text = "Text To Speech", font = 25,fg = 'red',bg = 'white', bd = 7)
outside.pack(padx= 10 ,pady = 10, expand = "yes" , fill ="both")

Label = Label(outside,text = "Text" , font = 15, fg = 'yellow' , bg = 'black')
Label.pack(padx = 10, side = tk.LEFT)

text = Entry(outside,width = 20, font = 25 ,bd = 5, textvariable = listen)
text.pack(side = tk.LEFT)

Button = Button(outside,font = 5 , text = "Enter", bg = 'red', fg = 'black', command = speak)
Button.pack(side = tk.RIGHT ,padx = 10)

root.mainloop()