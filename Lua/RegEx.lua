var = [[Content-Disposition: attachment; filename="403.htm.en"
     Content-Type: text/plain; name='403.htm.en'
     Content-Transfer-Encoding: BASE64
    ]]
filename = string.match(var,"filename=\"(.+)\"")
print("filename = ", filename)

--https://pt.stackoverflow.com/q/77463/101
