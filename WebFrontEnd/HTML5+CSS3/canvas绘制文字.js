/**
 * Created by Administrator on 2014/11/13.
 */
function draw(id) {
    var canvas = document.getElementById(id);
    var context = canvas.getContext('2d');
    context.fillStyle = 'green';
    context.fillRect(0, 0, 800, 300);
    context.fillStyle = '#fff';
    context.strokeStyle = '#fff';
    context.font = "bold 40px '����','����','΢���ź�','����'";
    context.textBaseline = 'hanging';
    //    context.textAlign = 'start';
    context.fillText('��ӭ�տ�����ѧԺ�Ƴ���', 10, 40);
    context.fillText('��HTML5+CSS3����������ʵս��', 40, 110);
    context.fillText('��Ƶ�̳�', 580, 180);
    //    context.fillText('123456789111121314151617181920212223242526272829��HTML5+CSS3����������ʵս����HTML5+CSS3����������ʵս����HTML5+CSS3����������ʵս��',0,230,800);
    //    context.strokeText('����ѧԺ',0,40);
}