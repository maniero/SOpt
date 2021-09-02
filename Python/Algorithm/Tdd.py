def teste_par_impar(self):
    self.assertEqual(par_impar(0), "par")
    self.assertEqual(par_impar(1), "impar")
    self.assertEqual(par_impar(2), "par")
    self.assertEqual(par_impar(-1), "impar")
    self.assertEqual(par_impar(-2), "par")
    self.assertEqual(par_impar(9999999999999999999999999999), "impar")
    self.assertEqual(par_impar(-2), "par")
    self.assertRaises(Exception, par_impar("1"))
    
#https://pt.stackoverflow.com/q/430375/101
