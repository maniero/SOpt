int left = height(p->left);
int right= height(p->right);
if (left > right) return 1 + left;
else return 1 + right
    
//https://pt.stackoverflow.com/q/260901/101
