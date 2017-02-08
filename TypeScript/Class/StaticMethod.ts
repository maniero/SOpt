export class Utils {
    constructor(public toastCtrl: ToastController) {}  

    static showToast(object, message, pos) {
        let toast = object.toastCtrl.create({
            message: message,
            duration: 3000,
            position: pos
        });
      toast.onDidDismiss(() => {
          console.log('Dismissed toast');
      });
      toast.present();
    }
}

//http://pt.stackoverflow.com/q/182951/101
