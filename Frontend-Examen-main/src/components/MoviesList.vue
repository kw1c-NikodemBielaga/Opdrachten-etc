<template>
  <div>
    <div v-if="toegang">
      <h2>Films overzicht</h2>
      <div class="container">
        <div v-for="movie in moviesList" :key="movie.id" class="row">
          Reader Vuejs hoofdstuk 1 pagina 18 van 39
          <div class="col">
<MovieCard :movie="movie" />
</div>
<div class="col">
<p><span>{{ movie.regisseur }}</span> - <em>
{{ movie.genre }}</em></p>
<p>{{ movie.samenvatting }}</p></div>
        </div>
      </div>
    </div>

    <div v-else>
      <h2>Login</h2>
      <form id="loginForm">
        <div class="form-group">
          <label for="email">Email</label>
          <input type="email" class="form-control" id="email" v-model="email">
        </div>
        <div class="form-group">
          <label for="password">Password</label>
          <input type="password" class="form-control" id="password" v-model="password">
        </div>
        <button type="button" @click="login" class="btn">Submit</button>
      </form>
    </div>
  </div>
</template>

<script>
import movies from '@/assets/data/movies.js'; // Controleer of het bestand hier echt staat!
import MovieCard from "@/components/MovieCard";

export default {
  name: 'MoviesList',
  components: {
    MovieCard,
  },
  data() {
    return {
      email: '',
      password: '',
      credentials: {
        email: 'abcd',
        password: '1234'
      },
      toegang: false,
      moviesList: movies
    };
  },
  methods: {
    login() {
      if (this.email === this.credentials.email && this.password === this.credentials.password) {
        this.toegang = true;
        alert('Welkom!');
      } else {
        alert('Verkeerde gegevens ingevoerd!');
      }
    }
  }
};
</script>

<style>
#loginForm {
  align-items: center;
  margin-top: 50px;
}
.col {
  border: 1px solid #000;
  background-color: #f0f0f0;
  padding: 10px;
  margin: 5px 0;
}
</style>