class Currency {
    constructor(firstCurrency,secondCurrency) {
        this.firstCurrency = firstCurrency;
        this.secondCurrency = secondCurrency;
        this.url= "https://api.apilayer.com/currency_data/live?base="; 
        this.amount = null;

        var myHeaders = new Headers(); myHeaders.append("apikey", "1miHr377ZgVSQNj0nZPe6WIKn9CQkcMD");
    }


    changeAmount(amount){
        this.amount = amount;
    }
    changeFirstCurrency(newFirstCurrency){
        this.firstCurrency = newFirstCurrency;
    }
    changeSecondCurrency(newSecondCurrency){
        this.secondCurrency = newSecondCurrency;
    }

    exchange()
{
    return new Promise((resolve,reject) => {
        fetch(this.url + this.firstCurrency)
    .then(response=> response.json())
    .then(data => {
        const parity = data["rates"][this.secondCurrency];
        const amount2 = Number(this.amount);

        let total = parity * amount2;

        resolve(total);
    })
    .catch(err =>reject(err))
    });
    
    
}

}
