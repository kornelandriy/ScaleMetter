import { Component } from '@angular/core';
import { TranslateService } from '../services/translate.service';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {

  constructor(private translate: TranslateService) {}

  isExpanded = false;

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  setLang(lang: string) {
    this.translate.use(lang);
  }
}
