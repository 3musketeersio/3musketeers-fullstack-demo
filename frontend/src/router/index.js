import Vue from 'vue'
import Router from 'vue-router'
import Home from '../views/Home.vue'
import { authGuard } from "../auth/authGuard";

Vue.use(Router)

export default new Router({
  mode: 'history',
  base: process.env.BASE_URL,
  routes: [
    {
      path: '/',
      name: 'home',
      component: Home
    },
    {
      path: '/about',
      name: 'about',
      component: () => import('../views/About.vue')
    },
    {
      path: '/events/:id',
      name: 'eventSingle',
      component: () => import('../views/EventSingle.vue'),
      beforeEnter: authGuard
    },
    {
      path: '/customers/:id',
      name: 'customerSingle',
      component: () => import('../views/CustomerSingle.vue'),
      beforeEnter: authGuard
    },
    {
      path: '*',
      component: () => import('../views/NotFound.vue')
    }
  ]
})
