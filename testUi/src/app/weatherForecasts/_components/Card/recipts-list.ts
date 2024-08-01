
import { Component, OnInit } from '@angular/core';



import { recipeModel } from '../../recipeModel'


@Component({
  selector: 'card',
  templateUrl: './card.html',
  styleUrls: ['./card.css']
})
export class CardComponent implements OnInit {
  public recipt: recipeModel = {} as recipeModel;

  constructor() { }

  ngOnInit() {
  }




}
