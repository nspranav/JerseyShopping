<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Catalog.aspx.cs" Inherits="JerseyShopping.Catalog" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Catalog- Jersey Hub</title>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
     <link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css"/>
     <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.0/jquery.min.js"></script>
    <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js"></script>
    <script type="text/javascript">
		function subtractQty(st){
			if(document.getElementById(st).value - 1 < 0)
				return;
			else
				 document.getElementById(st).value--;
		}
		</script>

</head>
<body>
    <form id="form1" runat="server">
    <div class="row">
        <div style="text-align:center" class="col-lg-12">
            <h1> Jersey Gallery</h1>
        </div>
        
    </div>
       
 <div class="container">       
  <div class="row">
      
               <div class="col-md-4">
                  <a href="Images/1.jpg" class="thumbnail">
                    <img src="Images/1.jpg" alt="Pulpit Rock"  style="width:150px;height:150px"/>
                  </a>
                  <p>
                      <p style="font-weight:bold">QTY: &nbsp  Cost: 10$</p>
                      <asp:TextBox Text="0" runat="server" ID="qty1" CssClass="col-lg-2"/>
                      &nbsp
			          <input type='button' name='add' onclick='javascript: document.getElementById("qty1").value++;' value='+'/>
			          <input type='button' name='subtract' onclick='subtractQty("qty1")' value='-'/>
                      <asp:Button style="column-rule-style:dashed" runat="server" id="button1" text="Add To Cart" OnClick="button1_Click"/>
                     
                 </p>
                  
            
    </div>
      
      
    <div class="col-md-4">
      <a href="Images/1.jpg" class="thumbnail">
       
        <img src="Images/2.jpg" alt="Moustiers Sainte Marie" style="width:150px;height:150px"/>
      </a>
        <p>
                      <p style="font-weight:bold">QTY: &nbsp  Cost: 10$</p>
                        <asp:TextBox Text="0" runat="server" ID="qty2" CssClass="col-lg-2"/>
                       &nbsp
			          <input type='button' name='add' onclick='javascript: document.getElementById("qty2").value++;' value='+'/>
			          <input type='button' name='subtract' onclick='subtractQty("qty2")' value='-'/>
                      <asp:Button style="column-rule-style:dashed" runat="server" id="button2" text="Add To Cart" OnClick="button2_Click"/>
                     
                 </p>
    </div>
    <div class="col-md-4">
      <a href="Images/3.jpg" class="thumbnail">
          
        <img src="Images/3.jpg" alt="Cinque Terre" style="width:150px;height:150px"/>
      </a>
       <p>
                      <p style="font-weight:bold">QTY: &nbsp  Cost: 10$</p>
                      <asp:TextBox Text="0" runat="server" ID="qty3" CssClass="col-lg-2"/> &nbsp
			          <input type='button' name='add' onclick='javascript: document.getElementById("qty3").value++;' value='+'/>
			          <input type='button' name='subtract' onclick='subtractQty("qty3")' value='-'/>
                      <asp:Button style="column-rule-style:dashed" runat="server" id="button3" text="Add To Cart" OnClick="button3_Click"/>
                     
                 </p>
    </div>
      <div class="col-md-4">
      <a href="Images/4.jpg" class="thumbnail">
        
        <img src="Images/4.jpg" alt="Cinque Terre" style="width:150px;height:150px"/>
      </a>
          <p>
                      <p style="font-weight:bold">QTY: &nbsp Cost: 10$ </p>
                      <asp:TextBox Text="0" runat="server" ID="qty4" CssClass="col-lg-2"/> &nbsp
			          <input type='button' name='add' onclick='javascript: document.getElementById("qty4").value++;' value='+'/>
			          <input type='button' name='subtract' onclick='subtractQty("qty4")' value='-'/>
                      <asp:Button style="column-rule-style:dashed" runat="server" id="button4" text="Add To Cart" OnClick="button4_Click"/>
                     
                 </p>
    </div>
      <div class="col-md-4">
      <a href="Images/5.jpg" class="thumbnail">
        
        <img src="Images/5.jpg" alt="Cinque Terre" style="width:150px;height:150px"/>
      </a>
          <p>
                      <p style="font-weight:bold">QTY: &nbsp  Cost: 10$</p>
                      <asp:TextBox Text="0" runat="server" ID="qty5" CssClass="col-lg-2"/> &nbsp
			          <input type='button' name='add' onclick='javascript: document.getElementById("qty5").value++;' value='+'/>
			          <input type='button' name='subtract' onclick='subtractQty("qty5")' value='-'/>
                      <asp:Button style="column-rule-style:dashed" runat="server" id="button5" text="Add To Cart" OnClick="button5_Click"/>
                     
                 </p>
    </div>
      <div class="col-md-4">
      <a href="Images/6.jpg" class="thumbnail">
        
        <img src="Images/6.jpg" alt="Cinque Terre" style="width:150px;height:150px"/>
      </a>
          <p>
                      <p style="font-weight:bold">QTY: &nbsp  Cost: 10$</p>
                      <asp:TextBox Text="0" runat="server" ID="qty6" CssClass="col-lg-2"/> &nbsp
			          <input type='button' name='add' onclick='javascript: document.getElementById("qty6").value++;' value='+'/>
			          <input type='button' name='subtract' onclick='subtractQty("qty6")' value='-'/>
                      <asp:Button style="column-rule-style:dashed" runat="server" id="button6" text="Add To Cart" OnClick="button6_Click"/>
                     
                 </p>
    </div>
      <div class="col-md-4">
      <a href="Images/7.jpg" class="thumbnail">
        
        <img src="Images/7.jpg" alt="Cinque Terre" style="width:150px;height:150px"/>

      </a>
          <p>
                      <p style="font-weight:bold">QTY: &nbsp  Cost: 10$</p>
                      <asp:TextBox Text="0" runat="server" ID="qty7" CssClass="col-lg-2"/> &nbsp
			          <input type='button' name='add' onclick='javascript: document.getElementById("qty7").value++;' value='+'/>
			          <input type='button' name='subtract' onclick='subtractQty("qty7")' value='-'/>
                      <asp:Button style="column-rule-style:dashed" runat="server" id="button7" text="Add To Cart" OnClick="button7_Click"/>
                     
                 </p>
    </div>
      <div class="col-md-4">
      <a href="Images/8.jpg" class="thumbnail">
        
        <img src="Images/8.jpg" alt="Cinque Terre" style="width:150px;height:150px"/>
      </a>
          <p>
                      <p style="font-weight:bold">QTY: &nbsp  Cost: 10$</p>
                      <asp:TextBox Text="0" runat="server" ID="qty8" CssClass="col-lg-2"/> &nbsp
			          <input type='button' name='add' onclick='javascript: document.getElementById("qty8").value++;' value='+'/>
			          <input type='button' name='subtract' onclick='subtractQty("qty8")' value='-'/>
                      <asp:Button style="column-rule-style:dashed" runat="server" id="button8" text="Add To Cart" OnClick="button8_Click"/>
                     
                 </p>
    </div>
      <div class="col-md-4">
      <a href="Images/13.jpg" class="thumbnail">
        
        <img src="Images/13.jpg" alt="Cinque Terre" style="width:150px;height:150px"/>
      </a>
          <p>
                      <p style="font-weight:bold">QTY: &nbsp  Cost: 10$</p>
                      <asp:TextBox Text="0" runat="server" ID="qty9" CssClass="col-lg-2"/> &nbsp
			          <input type='button' name='add' onclick='javascript: document.getElementById("qty9").value++;' value='+'/>
			          <input type='button' name='subtract' onclick='subtractQty("qty9")' value='-'/>
                      <asp:Button style="column-rule-style:dashed" runat="server" id="button9" text="Add To Cart" OnClick="button9_Click"/>
                     
                 </p>
    </div>
      <div class="col-md-4">
      <a href="Images/10.jpg" class="thumbnail">
        
        <img src="Images/10.jpg" alt="Cinque Terre" style="width:150px;height:150px"/>
      </a>
          <p>
                      <p style="font-weight:bold">QTY: &nbsp  Cost: 10$</p>
                      <asp:TextBox Text="0" runat="server" ID="qty10" CssClass="col-lg-2"/> &nbsp
			          <input type='button' name='add' onclick='javascript: document.getElementById("qty10").value++;' value='+'/>
			          <input type='button' name='subtract' onclick='subtractQty("qty10")' value='-'/>
                      <asp:Button style="column-rule-style:dashed" runat="server" id="button10" text="Add To Cart" OnClick="button10_Click"/>
                     
                 </p>
    </div>
      <div class="col-md-4">
      <a href="Images/11.jpg" class="thumbnail">
        
        <img src="Images/11.jpg" alt="Cinque Terre" style="width:150px;height:150px"/>
      </a>
          <p>
                      <p style="font-weight:bold">QTY: &nbsp  Cost: 10$</p>
                      <asp:TextBox Text="0" runat="server" ID="qty11" CssClass="col-lg-2"/> &nbsp
			          <input type='button' name='add' onclick='javascript: document.getElementById("qty11").value++;' value='+'/>
			          <input type='button' name='subtract' onclick='subtractQty("qty11")' value='-'/>
                      <asp:Button style="column-rule-style:dashed" runat="server" id="button11" text="Add To Cart" OnClick="button11_Click"/>
                     
                 </p>
    </div>
      <div class="col-md-4">
      <a href="Images/12.jpg" class="thumbnail">
        
        <img src="Images/12.jpg" alt="Cinque Terre" style="width:150px;height:150px"/>
      </a>
          <p>
                      <p style="font-weight:bold">QTY: &nbsp  Cost: 10$</p>
                      <asp:TextBox Text="0" runat="server" ID="qty12"  CssClass="col-lg-2"/> &nbsp
			          <input type='button' name='add' onclick='javascript: document.getElementById("qty12").value++;' value='+'/>
			          <input type='button' name='subtract' onclick='subtractQty("qty12")' value='-'/>
                      <asp:Button style="column-rule-style:dashed" runat="server" id="button12" text="Add To Cart" OnClick="button12_Click"/>
                     
                 </p>
    </div>

      <div style="align-self:center"class="col-lg-12">
          <pre style="text-align:center; margin:auto">
              <asp:Button Width="40%" Font-Size="Large" runat="server" ID="Checkout" Text="Continue To Checkout" CssClass="btn-success" OnClick="Checkout_Click"/>
          </pre>
      </div>
  </div>

</div>

    </form>
</body>
</html>
