import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HomeCatalogComponent } from './home-catalog.component';

describe('HomeCatalogComponent', () => {
  let component: HomeCatalogComponent;
  let fixture: ComponentFixture<HomeCatalogComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HomeCatalogComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(HomeCatalogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
