import { Component, Inject, ViewChild } from "@angular/core";
import { HttpClient, HttpParams } from "@angular/common/http";
import { Constants } from "../utility/constants.service";
import { MatTableDataSource, MatSort} from '@angular/material';  

@Component({
  selector: "divinationCards",
  templateUrl: "./divinationCards.component.html",
  styleUrls: ['./divinationCards.component.css']
})
export class DivinationCardsComponent {
  public combinationsWithFixedResults: ItemCombinationWithFixedResult[];
  public constants = Constants;
  public divinationCardsDataSource;
  public columnsToDisplay = ["cardName","outcome","profitPerTrade","profitPerSet","cardPrice"];
 
  constructor(http: HttpClient, @Inject("BASE_URL") baseUrl: string) {

    let headers = new Headers();
    headers.append("Content-Type", "application/json");
    let parameter = new HttpParams().set("combinationType", "divinationCardTurnIn");
    http.get<ItemCombinationWithFixedResult[]>(baseUrl + "api/ItemCombinations/FixedResults", { params: parameter }).subscribe(result => {

      this.combinationsWithFixedResults = result;
      this.divinationCardsDataSource = new MatTableDataSource(this.combinationsWithFixedResults);
      this.divinationCardsDataSource.sortingDataAccessor = (item, property) => {
        switch (property) {
          case 'cardName': return item.ingredients[0].item.name;
          case 'outcome' :
            return item.result.item.name;
          case 'profitPerTrade':
            return item.profitPerTradeInChaos;
          case 'profitPerSet':
            return item.profitInChaos;
          case 'cardPrice':
            return  item.ingredients[0].item.chaosValue;

        default: return item[property];
        }
      };
      this.divinationCardsDataSource.sort = this.sort;

    }, error => console.error(error));

    
  }
  @ViewChild(MatSort) sort: MatSort;

  
}

function ShowPopup(event) {

}


class PoeObject {

  constructor(
    name: string,
    chaosValue: number,
    exaltedValue: number,
    icon: string,
    priceChangeInChaos: number = 0) {
    
  }


}

class ItemWithAmount {
  constructor(
    item: PoeObject,
    amount: number
  ) {}
  
}

class ItemCombinationResult {
  constructor(
    item: PoeObject,
    corrupted: boolean,
    amount: number) {}
  
}

class ItemCombinationWithFixedResult {
  constructor(
    ingredients: ItemWithAmount[],
    result: ItemCombinationResult,
    requiredTrades: number,
    profitPerTradeInChaos: number,
    profitInChaos: number,
    profitInExalted: number,
  ) {}
  
}
