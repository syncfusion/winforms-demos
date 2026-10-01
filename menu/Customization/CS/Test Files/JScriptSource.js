 function OnSelectedRowChanged(gridobj,tr)
{		
  ClearPics();	
 selrow=tr.id;	
 ShowPicture();
}
function RadioButtonClick()
{	
  ClearPics();
  ShowPicture();
}
function OnFormLoad()
{

  CheckForRecordRow();
}     	
function CheckForRecordRow()
{	 
  var temp;
  var divid; 
  var j;
  temp=0;
  var divs=new Array();
  ClearPics();
  divs=document.getElementsByTagName("div");	
  for(j=0;j<divs.length;j++)
     {		
       divid=divs[j].id;
       if(divid.indexOf("GridGroupingControl1+_TOPGROUP")!=-1)
        {		
          temp=1;
        }	
     }	 
    if (temp==1)
     {
      selrow=tr.id;
      ShowPicture();
     }		
}   
function ClearPics()
{		
    var imgs = new Array();
    imgs= document.getElementsByTagName("img");
    var i;
    for(i=0;i<imgs.length;i++)
       {	
         var imgid;
         imgid=imgs[i].id;
         if(imgid.split('')[0]=='z')
           { 
             imgs[i].style.display='none';
           }
       }
}
function ShowPicture()
{		
   var imgs1 = new Array();
   imgs1= document.getElementsByTagName("img");
   var k;
  for(k=0;k<imgs1.length;k++)
   {
      var imgid1;
      imgid1=imgs1[k].id;
      if(document.form1.Rbt1.checked)				
        {	var identity=selrow;
	var tempid=identity.lastIndexOf("+");
              var name;
              name=identity.substring(tempid+1);
              var temp;
 	temp=name.substring(0,1);
	var imageKey3="z" + temp + "img";
	if(imageKey3==imgid1)
            {	
            document.getElementById(imageKey3).style.display='block';
            }
        }
    }
}