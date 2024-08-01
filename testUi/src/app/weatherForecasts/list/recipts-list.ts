
import { Component, OnInit } from '@angular/core';
import { CookieCHelper } from '../coocieHelper'

import { recipe } from '../recipe'
import { recipeModel } from '../recipeModel'

import { recipes } from '../mock-db';

@Component({
  selector: 'recipts-list',
  templateUrl: './recipts-list.html',
  styleUrls: ['./recipts-list.css']
})
export class ReciptsListComponent implements OnInit {
  public recipes: recipeModel[] = [];
  searchText: string="";

  constructor(private cookieHelper: CookieCHelper) { }

  ngOnInit() {
    this.getForecasts();
    console.log(this.recipes);
  }

  getForecasts() {
    let my_recipes = JSON.parse(this.cookieHelper.savedReciptCookie()) as recipe[];
    this.recipes = recipes.map((p, i) => ({
      id: p.id,
      name: p.name,
      desc: p.desc,
      images: p.images,
      recipes: p.recipes,
      img_index: 0,
      is_in_Favorite: my_recipes.some(x => x.id == p.id)
    }));

  }


  addToFavorite(recipe: recipe) {
    let my_recipes = JSON.parse(this.cookieHelper.savedReciptCookie()) as recipe[];
    if (my_recipes.some(x => x.id == recipe.id)) {
      my_recipes = my_recipes.filter(obj => obj.id !== recipe.id);
    }
    else {
      my_recipes.push(recipe);
    }
    this.cookieHelper.setCookie('fav', my_recipes, 100);
    this.getForecasts()
  }

  changeImgIndex(item: recipeModel, i: number) {   item.img_index=i;  }

}
